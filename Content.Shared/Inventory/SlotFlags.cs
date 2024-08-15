using Robust.Shared.Serialization;

namespace Content.Shared.Inventory;

/// <summary>
///     Defines what slot types an item can fit into.
/// </summary>
[Serializable, NetSerializable]
[Flags]
public enum SlotFlags
{
    NONE = 0,
    PREVENTEQUIP = 1 << 0,
    HEAD = 1 << 1,
    EYES = 1 << 2,
    EARS = 1 << 3,
    MASK = 1 << 4,
    OUTERCLOTHING = 1 << 5,
    INNERCLOTHING = 1 << 6,
    NECK = 1 << 7,
    BACK = 1 << 8,
    BELT = 1 << 9,
    GLOVES = 1 << 10,
    PDA = 1 << 11,  //space cats: add_id_revork
    POCKET = 1 << 12,
    ID = 1 << 13,  //space cats: add_id_revork
    LEGS = 1 << 14,
    FEET = 1 << 15,
    SUITSTORAGE = 1 << 16,
    UNDERPANTS = 1 << 17, //backmen:underclothing
    UNDERSHIRT = 1 << 18, //backmen:underclothing
    SOCKS = 1 << 19, //backmen:underclothing
    All = ~NONE,

    WITHOUT_POCKET = All & ~POCKET
}
