// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace YouYou.DataTable
{

using global::System;
using global::FlatBuffers;

public struct Sys_EffectList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Sys_EffectList GetRootAsSys_EffectList(ByteBuffer _bb) { return GetRootAsSys_EffectList(_bb, new Sys_EffectList()); }
  public static Sys_EffectList GetRootAsSys_EffectList(ByteBuffer _bb, Sys_EffectList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Sys_EffectList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Sys_Effect? SysEffects(int j) { int o = __p.__offset(4); return o != 0 ? (Sys_Effect?)(new Sys_Effect()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int SysEffectsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Sys_EffectList> CreateSys_EffectList(FlatBufferBuilder builder,
      VectorOffset Sys_EffectsOffset = default(VectorOffset)) {
    builder.StartObject(1);
    Sys_EffectList.AddSysEffects(builder, Sys_EffectsOffset);
    return Sys_EffectList.EndSys_EffectList(builder);
  }

  public static void StartSys_EffectList(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddSysEffects(FlatBufferBuilder builder, VectorOffset SysEffectsOffset) { builder.AddOffset(0, SysEffectsOffset.Value, 0); }
  public static VectorOffset CreateSysEffectsVector(FlatBufferBuilder builder, Offset<Sys_Effect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSysEffectsVectorBlock(FlatBufferBuilder builder, Offset<Sys_Effect>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartSysEffectsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Sys_EffectList> EndSys_EffectList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Sys_EffectList>(o);
  }
};


}
