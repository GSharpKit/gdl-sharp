// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdl {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DockItemButtonImage : Gtk.Widget {

		public DockItemButtonImage (IntPtr raw) : base(raw) {}

		[DllImport("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_item_button_image_new(int image_type);

		public DockItemButtonImage (Gdl.DockItemButtonImageType image_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DockItemButtonImage)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gdl_dock_item_button_image_new((int) image_type);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdlDockItemButtonImageClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Widget)).GetClassSize ();
		static Dictionary<GLib.GType, GdlDockItemButtonImageClass> class_structs;

		static GdlDockItemButtonImageClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdlDockItemButtonImageClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdlDockItemButtonImageClass class_struct = (GdlDockItemButtonImageClass) Marshal.PtrToStructure (class_ptr, typeof (GdlDockItemButtonImageClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdlDockItemButtonImageClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_item_button_image_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdl_dock_item_button_image_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}