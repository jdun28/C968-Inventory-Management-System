﻿using System;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class ValidateFields
    {
        public static bool IsInt(string text)
        {
            int number;
            return IsNotNullOrWhiteSpace(text) &&
                Int32.TryParse(text, out number);
        }
        public static bool IsNotNullOrWhiteSpace(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        public static bool IsDecimal(string text)
        {
            decimal dec;
            return IsNotNullOrWhiteSpace(text) &&
                Decimal.TryParse(text, out dec);
        }

        public static void ValidateField(RichTextBox field, bool isValid)
        {
            if (isValid)
            {
                field.BackColor = System.Drawing.Color.White;
            }
            else
            {
                field.BackColor = System.Drawing.Color.Salmon;
            }
        }

        public static bool InvBetweenMinMax(string inv, string max, string min)
        {
            int QOH;
            int MaxInv;
            int MinInv;

            Int32.TryParse(inv, out QOH);
            Int32.TryParse(max, out MaxInv);
            Int32.TryParse(min, out MinInv);

            return (MaxInv >= QOH) && (QOH >= MinInv);
        }
    }
}
