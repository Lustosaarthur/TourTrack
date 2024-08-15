using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TourTrack.App.services.Behaviors
{
    public class EntryUnfocusBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty UnfocusedCommandProperty =
            BindableProperty.Create(nameof(UnfocusedCommand), typeof(ICommand), typeof(EntryUnfocusBehavior));

        public ICommand UnfocusedCommand
        {
            get => (ICommand)GetValue(UnfocusedCommandProperty);
            set => SetValue(UnfocusedCommandProperty, value);
        }

        protected override void OnAttachedTo(Entry entry)
        {
            base.OnAttachedTo(entry);
            entry.Unfocused += OnEntryUnfocused;
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);
            entry.Unfocused -= OnEntryUnfocused;
        }

        private void OnEntryUnfocused(object sender, FocusEventArgs e)
        {
            if (UnfocusedCommand?.CanExecute(null) == true)
            {
                UnfocusedCommand.Execute(null);
            }
        }
    }
}
