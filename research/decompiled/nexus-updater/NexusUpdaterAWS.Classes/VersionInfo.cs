namespace NexusUpdaterAWS.Classes;

internal class VersionInfo
{
	public int Major;

	public int Minor;

	public int BugFix;

	public int Release;

	public bool IsRelease => Release == 0;

	public bool IsAlpha
	{
		get
		{
			if (Release != 0)
			{
				return Release <= 100;
			}
			return false;
		}
	}

	public bool IsBeta
	{
		get
		{
			if (Release > 100)
			{
				return Release <= 200;
			}
			return false;
		}
	}

	public bool IsExperimental => Release > 200;

	public VersionInfo(int major, int minor, int bugfix, int release)
	{
		Major = major;
		Minor = minor;
		BugFix = bugfix;
		Release = release;
	}

	public override string ToString()
	{
		string release;
		if (IsRelease)
		{
			release = "Release";
		}
		else if (IsAlpha)
		{
			release = $"Alpha {Release}";
		}
		else
		{
			release = ((!IsBeta) ? $"Experimental {Release - 200}" : $"Beta {Release - 100}");
		}
		return string.Format("{0}.{1}.{2} - {3}", new object[4]
		{
			Major,
			Minor.ToString("00"),
			BugFix,
			release
		});
	}

	public static int ReformReleaseType(int releaseType)
	{
		int reformedReleaseType = releaseType;
		if (reformedReleaseType == 0)
		{
			reformedReleaseType = 201;
		}
		else if (reformedReleaseType >= 201)
		{
			reformedReleaseType++;
		}
		return reformedReleaseType;
	}

	public static bool operator ==(VersionInfo c1, VersionInfo c2)
	{
		if ((object)c1 == null || (object)c2 == null)
		{
			return (object)c1 == c2;
		}
		if (c1.Major == c2.Major && c1.Minor == c2.Minor && c1.BugFix == c2.BugFix)
		{
			return c1.Release == c2.Release;
		}
		return false;
	}

	public static bool operator !=(VersionInfo c1, VersionInfo c2)
	{
		return !(c1 == c2);
	}

	public static bool operator >(VersionInfo c1, VersionInfo c2)
	{
		if (c1.Major <= c2.Major && (c1.Major != c2.Major || c1.Minor <= c2.Minor) && (c1.Major != c2.Major || c1.Minor != c2.Minor || c1.BugFix <= c2.BugFix))
		{
			if (c1.Major == c2.Major && c1.Minor == c2.Minor && c1.BugFix == c2.BugFix)
			{
				return ReformReleaseType(c1.Release) > ReformReleaseType(c2.Release);
			}
			return false;
		}
		return true;
	}

	public static bool operator >=(VersionInfo c1, VersionInfo c2)
	{
		if (c1.Major <= c2.Major && (c1.Major != c2.Major || c1.Minor <= c2.Minor) && (c1.Major != c2.Major || c1.Minor != c2.Minor || c1.BugFix <= c2.BugFix))
		{
			if (c1.Major == c2.Major && c1.Minor == c2.Minor && c1.BugFix == c2.BugFix)
			{
				return ReformReleaseType(c1.Release) > ReformReleaseType(c2.Release);
			}
			return false;
		}
		return true;
	}

	public static bool operator <(VersionInfo c1, VersionInfo c2)
	{
		if (c1.Major >= c2.Major && (c1.Major != c2.Major || c1.Minor >= c2.Minor) && (c1.Major != c2.Major || c1.Minor != c2.Minor || c1.BugFix >= c2.BugFix))
		{
			if (c1.Major == c2.Major && c1.Minor == c2.Minor && c1.BugFix == c2.BugFix)
			{
				return ReformReleaseType(c1.Release) < ReformReleaseType(c2.Release);
			}
			return false;
		}
		return true;
	}

	public static bool operator <=(VersionInfo c1, VersionInfo c2)
	{
		if (c1.Major >= c2.Major && (c1.Major != c2.Major || c1.Minor >= c2.Minor) && (c1.Major != c2.Major || c1.Minor != c2.Minor || c1.BugFix >= c2.BugFix))
		{
			if (c1.Major == c2.Major && c1.Minor == c2.Minor && c1.BugFix == c2.BugFix)
			{
				return ReformReleaseType(c1.Release) < ReformReleaseType(c2.Release);
			}
			return false;
		}
		return true;
	}
}
