// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdl {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gdl.DockItemFlagsGType))]
	public enum DockItemFlags {

		InDrag = 1 << 8,
		InPredrag = 1 << 9,
		Iconified = 1 << 10,
		UserAction = 1 << 11,
	}

	internal class DockItemFlagsGType {
		[DllImport ("libgdl-3.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_item_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdl_dock_item_flags_get_type ());
			}
		}
	}
#endregion
}
