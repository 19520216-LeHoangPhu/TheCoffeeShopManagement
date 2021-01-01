﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class AddItem : AddObj
    {
        public override void AddImageClicked(ref PictureBox pbImageItem, object item = null)
        {
            AddImage(ref pbImageItem, "./ImageItem/", ID.FindNewID("MON", " ORDER BY MAMON DESC",
                "MAMON", "M", 3).ToString());
        }

        public override void AddNewObj(object item, object tmp = null)
        {
            Item newItem = (Item)item;

            switch (Item.IsItem(ref newItem))
            {
                case 0:
                {
                    IO.ExportError("Món này đã có trong danh sách");
                    return;
                }
                case 1:
                {
                    Data.AddData("MON", newItem.GetInfo());
                    break;
                }
                case 2:
                {
                    Data.UpdateData("MON", "DVT = '" + newItem.unit + "', GIA = " + newItem.price
                        + ", TINHTRANG = 1, SOLANPHUCVU = 0", " WHERE MAMON = '" +
                        newItem.id.ToString() + "'");
                    break;
                }
                case -1:
                {
                    return;
                }
            }

            IO.ExportSuccess("Thêm món thành công");
        }

    }
}