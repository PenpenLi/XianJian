// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace YouYou.DataTable
{

using global::System;
using global::FlatBuffers;

public struct ShopCategoryList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ShopCategoryList GetRootAsShopCategoryList(ByteBuffer _bb) { return GetRootAsShopCategoryList(_bb, new ShopCategoryList()); }
  public static ShopCategoryList GetRootAsShopCategoryList(ByteBuffer _bb, ShopCategoryList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ShopCategoryList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ShopCategory? ShopCategorys(int j) { int o = __p.__offset(4); return o != 0 ? (ShopCategory?)(new ShopCategory()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ShopCategorysLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<ShopCategoryList> CreateShopCategoryList(FlatBufferBuilder builder,
      VectorOffset ShopCategorysOffset = default(VectorOffset)) {
    builder.StartObject(1);
    ShopCategoryList.AddShopCategorys(builder, ShopCategorysOffset);
    return ShopCategoryList.EndShopCategoryList(builder);
  }

  public static void StartShopCategoryList(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddShopCategorys(FlatBufferBuilder builder, VectorOffset ShopCategorysOffset) { builder.AddOffset(0, ShopCategorysOffset.Value, 0); }
  public static VectorOffset CreateShopCategorysVector(FlatBufferBuilder builder, Offset<ShopCategory>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShopCategorysVectorBlock(FlatBufferBuilder builder, Offset<ShopCategory>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartShopCategorysVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ShopCategoryList> EndShopCategoryList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ShopCategoryList>(o);
  }
};


}
