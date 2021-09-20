// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.WindowsAPICodePack.Shell
{
    /// <summary>Defines the read-only properties for default shell icon sizes.</summary>
    public static class DefaultIconSize
    {
        /// <summary>The extra-large size property for a 256x256 pixel Shell Icon.</summary>
        public static readonly System.Drawing.Size ExtraLarge = new System.Drawing.Size(256, 256);

        /// <summary>The large size property for a 48x48 pixel Shell Icon.</summary>
        public static readonly System.Drawing.Size Large = new System.Drawing.Size(48, 48);

        /// <summary>The maximum size for a Shell Icon, 256x256 pixels.</summary>
        public static readonly System.Drawing.Size Maximum = new System.Drawing.Size(256, 256);

        /// <summary>The medium size property for a 32x32 pixel Shell Icon.</summary>
        public static readonly System.Drawing.Size Medium = new System.Drawing.Size(32, 32);

        /// <summary>The small size property for a 16x16 pixel Shell Icon.</summary>
        public static readonly System.Drawing.Size Small = new System.Drawing.Size(16, 16);
    }

    /// <summary>Defines the read-only properties for default shell thumbnail sizes.</summary>
    public static class DefaultThumbnailSize
    {
        /// <summary>Gets the extra-large size property for a 1024x1024 pixel Shell Thumbnail.</summary>
        public static readonly System.Drawing.Size ExtraLarge = new System.Drawing.Size(1024, 1024);

        /// <summary>Gets the large size property for a 256x256 pixel Shell Thumbnail.</summary>
        public static readonly System.Drawing.Size Large = new System.Drawing.Size(256, 256);

        /// <summary>Maximum size for the Shell Thumbnail, 1024x1024 pixels.</summary>
        public static readonly System.Drawing.Size Maximum = new System.Drawing.Size(1024, 1024);

        /// <summary>Gets the medium size property for a 96x96 pixel Shell Thumbnail.</summary>
        public static readonly System.Drawing.Size Medium = new System.Drawing.Size(96, 96);

        /// <summary>Gets the small size property for a 32x32 pixel Shell Thumbnail.</summary>
        public static readonly System.Drawing.Size Small = new System.Drawing.Size(32, 32);
    }
}