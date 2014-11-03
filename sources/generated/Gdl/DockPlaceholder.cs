// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdl {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Obsolete]
	public partial class DockPlaceholder : Gdl.DockObject {

		public DockPlaceholder (IntPtr raw) : base(raw) {}

		[DllImport("libgdl-3.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_placeholder_new(IntPtr name, IntPtr objekt, int position, bool sticky);

		public DockPlaceholder (string name, Gdl.DockObject objekt, Gdl.DockPlacement position, bool sticky) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DockPlaceholder)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gdl_dock_placeholder_new(native_name, objekt == null ? IntPtr.Zero : objekt.Handle, (int) position, sticky);
			GLib.Marshaller.Free (native_name);
		}

		[GLib.Property ("sticky")]
		public bool Sticky {
			get {
				GLib.Value val = GetProperty ("sticky");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("host")]
		public Gdl.DockObject Host {
			get {
				GLib.Value val = GetProperty ("host");
				Gdl.DockObject ret = (Gdl.DockObject) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("host", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("next-placement")]
		public Gdl.DockPlacement NextPlacement {
			get {
				GLib.Value val = GetProperty ("next-placement");
				Gdl.DockPlacement ret = (Gdl.DockPlacement) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("next-placement", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("width")]
		public int Width {
			get {
				GLib.Value val = GetProperty ("width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("width", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("height")]
		public int Height {
			get {
				GLib.Value val = GetProperty ("height");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("height", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("floating")]
		public bool Floating {
			get {
				GLib.Value val = GetProperty ("floating");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("floatx")]
		public int Floatx {
			get {
				GLib.Value val = GetProperty ("floatx");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("floaty")]
		public int Floaty {
			get {
				GLib.Value val = GetProperty ("floaty");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdlDockPlaceholderClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gdl.DockObject)).GetClassSize ();
		static Dictionary<GLib.GType, GdlDockPlaceholderClass> class_structs;

		static GdlDockPlaceholderClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdlDockPlaceholderClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdlDockPlaceholderClass class_struct = (GdlDockPlaceholderClass) Marshal.PtrToStructure (class_ptr, typeof (GdlDockPlaceholderClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdlDockPlaceholderClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdl-3.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdl_dock_placeholder_attach(IntPtr raw, IntPtr objekt);

		public void Attach(Gdl.DockObject objekt) {
			gdl_dock_placeholder_attach(Handle, objekt == null ? IntPtr.Zero : objekt.Handle);
		}

		[DllImport("libgdl-3.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdl_dock_placeholder_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdl_dock_placeholder_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
