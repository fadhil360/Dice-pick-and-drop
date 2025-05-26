﻿using UnityEngine.UIElements;

namespace Preliy.Flange.Editor
{
    public static class PropertyFieldExtension
    {
        public static BaseField<T> AlignedField<T>(this BaseField<T> field)
        {
            field.AddToClassList(BaseField<T>.alignedFieldUssClassName);
            return field;
        }
    }
}
