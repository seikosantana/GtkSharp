// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class HookList : GLib.Opaque {

		// Internal representation of the wrapped ABI structure.
		static public unsafe AbiStruct abi_info = new AbiStruct(new List<AbiField> {
				new GLib.AbiField("seq_id"
						, 0
						, (uint) sizeof (ulong) // seq_id
						, null
						, "hook_size"
						, (long) Marshal.OffsetOf(typeof(GHookList_seq_idAlign), "seq_id")
						, 0
						),
				new GLib.AbiField("hook_size"
						, -1
						, (uint) sizeof (uint) // hook_size
						, "seq_id"
						, "is_setup"
						, 1
						, 16
						),
				new GLib.AbiField("is_setup"
						, -1
						, (uint) sizeof(uint) // is_setup
						, "hook_size"
						, "hooks"
						, 1
						, 1
						),
				new GLib.AbiField("hooks"
						, -1
						, (uint) sizeof (IntPtr) // hooks
						, "is_setup"
						, "dummy3"
						, (long) Marshal.OffsetOf(typeof(GHookList_hooksAlign), "hooks")
						, 0
						),
				new GLib.AbiField("dummy3"
						, -1
						, (uint) sizeof (IntPtr) // dummy3
						, "hooks"
						, "finalize_hook"
						, (long) Marshal.OffsetOf(typeof(GHookList_dummy3Align), "dummy3")
						, 0
						),
				new GLib.AbiField("finalize_hook"
						, -1
						, (uint) sizeof (IntPtr) // finalize_hook
						, "dummy3"
						, "dummy"
						, (long) Marshal.OffsetOf(typeof(GHookList_finalize_hookAlign), "finalize_hook")
						, 0
						),
				new GLib.AbiField("dummy"
						, -1
						, (uint) sizeof (IntPtr) * 2 // dummy
						, "finalize_hook"
						, null
						, (long) Marshal.OffsetOf(typeof(GHookList_dummyAlign), "dummy")
						, 0
						)
			}
		);

		[StructLayout(LayoutKind.Sequential)]
		public struct GHookList_seq_idAlign
		{
			sbyte f1;
			private UIntPtr seq_id;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GHookList_hooksAlign
		{
			sbyte f1;
			private IntPtr hooks;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GHookList_dummy3Align
		{
			sbyte f1;
			private IntPtr dummy3;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GHookList_finalize_hookAlign
		{
			sbyte f1;
			private IntPtr finalize_hook;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GHookList_dummyAlign
		{
			sbyte f1;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=2)]
			private IntPtr[] dummy;
		}
		// End of the ABI representation.

#endregion
	}
}
