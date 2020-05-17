using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftStar.Item
{
	public interface IItem
	{
        /// <summary>
        /// ��������
        /// </summary>
		ItemPackage OwnerPackage { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        List<ItemGroup> OwnerGroup { get; }

        IItemType ItemType { get; }

		uint ID { get; }

		IEnumerator Prepare();

		Dictionary<string, byte[]> UserDefinedData { get; }

		bool IsInitialized { get; set; }
	}
}
