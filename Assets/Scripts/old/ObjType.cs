using System;

/// <summary>
/// ��Ʒ����
/// </summary>
public enum ObjType
{
	monster,
	player,
	WeaponTrader,
	CanPay,
	CanGet,
	CanNotPay,
	CanNotGet,
	MainLine,
    /// <summary>
    /// ���߲��ܵõ�
    /// </summary>
	MainLineCanNotGet,
	BranchCanGet0,
	BranchCanNotGet0,
	BranchCanGet1,
	BranchCanNotGet1,
	BranchCanGet2,
	BranchCanNotGet2,
	BranchCanGet3,
	BranchCanNotGet3,
	BranchCanGet4,
	BranchCanNotGet4,
	BranchCanGet5,
	BranchCanNotGet5,
    /// <summary>
    /// û����
    /// </summary>
	none0,
	Enter,
	FuZhuang,
	RanFang,
	WuQi,
	XiuXi,
	YaoDian,
	ZaHuoDian,
	BaoXiang,
    /// <summary>
    /// û����
    /// </summary>
    none,
	HuanHua,
	CanContinue
}
