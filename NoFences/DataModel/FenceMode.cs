namespace NoFences.DataModel
{
    public enum FenceMode
    {
        /// <summary>
        /// The classic operating mode, where the fence just has weak references
        /// to the files that are in it.
        /// </summary>
        ShortcutBased,

        /// <summary>
        /// Operating mode where the fence actually owns the files, and they are 
        /// no longer visible in their original location.
        /// </summary>
        Owning,

        /// <summary>
        /// Operating mode where the fence mirrors the contents of another folder.
        /// This is also known as "portal" mode.
        /// </summary>
        Mirroring,
    }
}
