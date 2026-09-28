using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffStatHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ShiftLeft_Button_Click(object sender, EventArgs e)
        {
            BuffValue_Text.Text = GetBuffStat(int.Parse(ShiftLeft_Text.Text));
        }

        private void Buffstat_Button_Click(object sender, EventArgs e)
        {
            BuffValue_Text.Text = GetBitIndex(BuffStat_Text.Text).ToString();
        }


        public static string GetBuffStat(int bitIndex)
        {
            if (bitIndex < 0 || bitIndex >= 320)
                throw new ArgumentOutOfRangeException("bitIndex");

            int position = (bitIndex / 32) + 1;
            uint value = 1u << (bitIndex & 31);

            return string.Format("0x{0:X8}, {1}", value, position);
        }

        public static int GetBitIndex(string buffStat)
        {
            string[] parts = buffStat.Split(',');

            if (parts.Length != 2)
                throw new ArgumentException("형식: 0x08000000, 1");

            uint value = Convert.ToUInt32(
                parts[0].Trim().Replace("0x", ""),
                16
            );

            int position = Convert.ToInt32(parts[1].Trim());

            if (value == 0 || position < 1 || position > 10)
                throw new ArgumentOutOfRangeException("buffStat");

            int bit = 0;

            while (value > 1)
            {
                value >>= 1;
                bit++;
            }

            return ((position - 1) * 32) + bit;
        }


        /*
        UINT128* __thiscall UINT128::shiftLeft(UINT128*this, signed int a2)
        {
            unsigned int v2; // ebp
            UINT128* v3; // esi
            int v5; // edi
            int v6; // ebx
            char v7; // cl
            int v8; // ebx
            unsigned __int64 v9; // kr00_8
            int v10; // eax
            signed int v11; // [esp+Ch] [ebp-30h]
            char v12; // [esp+10h] [ebp-2Ch]
            int v13; // [esp+38h] [ebp-4h]
            int* v14; // [esp+40h] [ebp+4h]

            v2 = 0;
            v3 = this;
            if (a2 && UINT128::compareTo(this, 0))
            {
                if ((unsigned int)a2 >= 320 )
                {
                    sub_407220(0);
                    return v3;
                }
                v13 = 0;
                v5 = a2 / 32;
                v6 = 0;
                v11 = 9;
                if (a2 / 32 <= 9)
                {
                    v7 = a2 & 0x1F;
                    v12 = a2 & 0x1F;
                    v14 = &v13 - v5;
                    while (1)
                    {
                        v9 = ((unsigned __int64) * ((unsigned int*)v3 + v11) << v7) +__PAIR__(v6, v2);
                        v8 = v9 >> 32;
                        *v14 = v9;
                        v2 = v8;
                        v6 = v8 >> 31;
                        --v11;
                        --v14;
                        if (v11 < v5)
                            break;
                        v7 = v12;
                    }
                }
                *(_DWORD*)v3 = 0;
                *((_DWORD*)v3 + 1) = 0;
                *((_DWORD*)v3 + 2) = 0;
                *((_DWORD*)v3 + 3) = 0;
                *((_DWORD*)v3 + 4) = 0;
                *((_DWORD*)v3 + 5) = 0;
                *((_DWORD*)v3 + 6) = 0;
                v10 = v13;
                *((_DWORD*)v3 + 7) = 0;
                *((_DWORD*)v3 + 8) = 0;
                *((_DWORD*)v3 + 9) = v10;
            }
            return v3;
        }

        */

    }
}
