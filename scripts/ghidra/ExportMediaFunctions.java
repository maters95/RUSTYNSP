import ghidra.app.decompiler.DecompInterface;
import ghidra.app.decompiler.DecompileResults;
import ghidra.app.script.GhidraScript;
import ghidra.program.model.listing.Function;
import ghidra.program.model.listing.FunctionIterator;
import java.io.BufferedWriter;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;

public class ExportMediaFunctions extends GhidraScript {
	@Override
	public void run() throws Exception {
		String[] args = getScriptArgs();
		if (args.length != 1) {
			throw new IllegalArgumentException("Expected output directory argument");
		}
		Path output = Path.of(args[0]);
		Files.createDirectories(output);
		DecompInterface decompiler = new DecompInterface();
		decompiler.openProgram(currentProgram);
		int exported = 0;
		try (BufferedWriter writer = Files.newBufferedWriter(
				output.resolve("media-functions.c"), StandardCharsets.UTF_8)) {
			FunctionIterator functions = currentProgram.getFunctionManager().getFunctions(true);
			while (functions.hasNext()) {
				monitor.checkCancelled();
				Function function = functions.next();
				String name = function.getName();
				String lower = name.toLowerCase();
				if (!(lower.contains("qml") || lower.contains("resource") ||
					lower.contains("image") || lower.contains("media") ||
					lower.contains("component") || lower.contains("plugin"))) {
					continue;
				}
				DecompileResults result = decompiler.decompileFunction(function, 30, monitor);
				writer.write("// " + name + " @ " + function.getEntryPoint() + "\n");
				if (result.decompileCompleted()) {
					writer.write(result.getDecompiledFunction().getC());
				}
				else {
					writer.write("/* decompile failed: " + result.getErrorMessage() + " */\n");
				}
				writer.write("\n\n");
				exported++;
			}
		}
		decompiler.dispose();
		println("Exported " + exported + " matching functions to " + output);
	}
}