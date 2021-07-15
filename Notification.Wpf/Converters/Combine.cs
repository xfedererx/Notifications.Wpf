using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using Notification.Wpf.Converters;
using Notifications.Wpf.Annotations;

namespace Notification.Wpf
{
    /// <summary>���������, ��������������� ������������� �������� ���� ������ �����������</summary>
    [MarkupExtensionReturnType(typeof(Combine))]
    internal class Combine : ValueConverter
    {
        /// <summary>������ ����������� ���������</summary>
        [CanBeNull]
        public IValueConverter First { get; set; }

        /// <summary>������ ����������� ���������</summary>
        [CanBeNull]
        public IValueConverter Then { get; set; }

        public override object Convert(object v, Type t, object p, CultureInfo c)
        {
            if (First != null) v = First.Convert(v, t, p, c);
            if (Then != null) v = Then.Convert(v, t, p, c);
            return v;
        }

        public override object ConvertBack(object v, Type t, object p, CultureInfo c)
        {
            if (Then != null) v = Then.ConvertBack(v, t, p, c);
            if (First != null) v = First.ConvertBack(v, t, p, c);
            return v;
        }
    }
}