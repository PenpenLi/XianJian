using SoftStar.Item;
using SoftStar.Pal6;
using System;
using System.Collections.Generic;

/// <summary>
/// ��Ҷ�������
/// </summary>
[Serializable]
public class PlayerTeamData
{
    /// <summary>
    /// ���
    /// </summary>
	public bool Enqueue = true;

    /// <summary>
    /// Ѫ��
    /// </summary>
	public int HP;

    /// <summary>
    /// ��ɫID
    /// </summary>
	public int mCharacterID = -1;

    /// <summary>
    /// �ȼ�
    /// </summary>
    public int mLevel = 1;

    /// <summary>
    /// ������Ϣ�б�
    /// </summary>
	public List<PalNPC.SkillInfo> m_SkillIDs = new List<PalNPC.SkillInfo>();

    /// <summary>
    /// ��ƷID
    /// </summary>
	public List<ItemD> m_ItemIDs = new List<ItemD>();
}
