// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdl {

	using System;

	public delegate void DockDragMotionHandler(object o, DockDragMotionArgs args);

	public class DockDragMotionArgs : GLib.SignalArgs {
		public Gdk.Device Device{
			get {
				return (Gdk.Device) Args [0];
			}
		}

		public int X{
			get {
				return (int) Args [1];
			}
		}

		public int Y{
			get {
				return (int) Args [2];
			}
		}

	}
}
