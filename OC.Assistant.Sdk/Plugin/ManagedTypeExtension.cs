namespace OC.Assistant.Sdk.Plugin;

/// <summary>
/// Static class with <see cref="ManagedType"/> extensions.
/// </summary>
public static class ManagedTypeExtension
{
    /// <param name="type">The <see cref="ManagedType"/> to extend.</param>
    extension(ManagedType type)
    {
        /// <summary>
        /// Returns a managed string of this <see cref="ManagedType"/>.
        /// </summary>
        public string Name()
        {
            return type.ToString().ToUpper();
        }

        /// <summary>
        /// Returns the BitSize of this <see cref="ManagedType"/>.
        /// </summary>
        public int BitSize()
        {
            return BitSizeByType[type];
        }
    }

    private static readonly Dictionary<ManagedType, int> BitSizeByType = new()
    {
        { ManagedType.Bit, 1 },
        { ManagedType.Bool, 8 },
        { ManagedType.Byte, 8 },
        { ManagedType.UsInt, 8 },
        { ManagedType.SInt, 8 },
        { ManagedType.Word, 16 },
        { ManagedType.Uint, 16 },
        { ManagedType.Int, 16 },
        { ManagedType.Dword, 32 },
        { ManagedType.UDint, 32 },
        { ManagedType.Dint, 32 },
        { ManagedType.Real, 32 },
        { ManagedType.LWord, 64 },
        { ManagedType.Lint, 64 },
        { ManagedType.ULint, 64 },
        { ManagedType.LReal, 64 },
        { ManagedType.Unknown, 0 }
    };
}