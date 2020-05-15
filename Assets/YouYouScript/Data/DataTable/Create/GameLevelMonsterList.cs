// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace YouYou.DataTable
{

using global::System;
using global::FlatBuffers;

public struct GameLevelMonsterList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static GameLevelMonsterList GetRootAsGameLevelMonsterList(ByteBuffer _bb) { return GetRootAsGameLevelMonsterList(_bb, new GameLevelMonsterList()); }
  public static GameLevelMonsterList GetRootAsGameLevelMonsterList(ByteBuffer _bb, GameLevelMonsterList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public GameLevelMonsterList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public GameLevelMonster? GameLevelMonsters(int j) { int o = __p.__offset(4); return o != 0 ? (GameLevelMonster?)(new GameLevelMonster()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int GameLevelMonstersLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<GameLevelMonsterList> CreateGameLevelMonsterList(FlatBufferBuilder builder,
      VectorOffset GameLevelMonstersOffset = default(VectorOffset)) {
    builder.StartObject(1);
    GameLevelMonsterList.AddGameLevelMonsters(builder, GameLevelMonstersOffset);
    return GameLevelMonsterList.EndGameLevelMonsterList(builder);
  }

  public static void StartGameLevelMonsterList(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddGameLevelMonsters(FlatBufferBuilder builder, VectorOffset GameLevelMonstersOffset) { builder.AddOffset(0, GameLevelMonstersOffset.Value, 0); }
  public static VectorOffset CreateGameLevelMonstersVector(FlatBufferBuilder builder, Offset<GameLevelMonster>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateGameLevelMonstersVectorBlock(FlatBufferBuilder builder, Offset<GameLevelMonster>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartGameLevelMonstersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<GameLevelMonsterList> EndGameLevelMonsterList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GameLevelMonsterList>(o);
  }
};


}