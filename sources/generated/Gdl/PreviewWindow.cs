// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdl {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PreviewWindow : Gtk.Window {

		public PreviewWindow (IntPtr raw) : base(raw) {}

		[DllImport("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_preview_window_new();

		public PreviewWindow () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PreviewWindow)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gdl_preview_window_new();
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdlPreviewWindowClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Window)).GetClassSize ();
		static Dictionary<GLib.GType, GdlPreviewWindowClass> class_structs;

		static GdlPreviewWindowClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdlPreviewWindowClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdlPreviewWindowClass class_struct = (GdlPreviewWindowClass) Marshal.PtrToStructure (class_ptr, typeof (GdlPreviewWindowClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdlPreviewWindowClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_preview_window_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdl_preview_window_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgdl-3-5.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdl_preview_window_update(IntPtr raw, IntPtr rect);

		public void Update(Gdk.Rectangle rect) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			gdl_preview_window_update(Handle, native_rect);
			Marshal.FreeHGlobal (native_rect);
		}

#endregion
	}
}