using FFXIVClientStructs.FFXIV.Client.Graphics;

namespace FFXIVClientStructs.FFXIV.Client.Game.Character;
// Client::Game::Character::BattleChara
//   Client::Game::Character::Character
//     Client::Game::Object::GameObject
//     Client::Graphics::Vfx::VfxDataListenner
// characters that fight (players, monsters, etc)

// size = 0x2C40
// ctor E8 ? ? ? ? 48 8B F8 EB 02 33 FF 8B 86 ? ? ? ? 
[StructLayout(LayoutKind.Explicit, Size = 0x2D30)]
public unsafe partial struct BattleChara
{
    [FieldOffset(0x0)] public Character Character;

    [FieldOffset(0x1B20)] public StatusManager StatusManager;

    [FieldOffset(0x1CB0)] public Character.CastInfo SpellCastInfo;

    //[FieldOffset(0x1E20)] public fixed byte UnkBattleCharaStruct[0xF00];

    [FieldOffset(0x2D20)] public Character.ForayInfo Foray;

    public StatusManager* GetStatusManager => Character.GetStatusManager();
    public Character.CastInfo* GetCastInfo => Character.GetCastInfo();
    public Character.ForayInfo* GetForayInfo => Character.GetForayInfo();
}