﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="hb_subtitle.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the hb_subtitle_s type.
// </summary>
// <auto-generated> Disable Stylecop Warnings for this file  </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.HbLib
{
	using System;
	using System.Runtime.InteropServices;

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct hb_subtitle_s
	{
		/// int
		public int id;

		/// int
		public int track;

		public int out_track;

		/// hb_subtitle_config_t->hb_subtitle_config_s
		public hb_subtitle_config_s config;

		/// hb_subtitle_s_subtype
		public hb_subtitle_s_subtype format;

		/// hb_subtitle_s_subsource
		public hb_subtitle_s_subsource source;

		/// char[1024]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string lang;

		/// char[4]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public string iso639_2;

		/// uint8_t->unsigned char
		public byte type;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
		public uint[] palette;

		public byte palette_set;

		public int width;

		public int height;

		public IntPtr extradata;

		public int extradata_size;

		/// int
		public int hits;

		/// int
		public int forced_hits;

		public uint codec;

		public uint reg_desc;

		public uint stream_type;

		public uint substream_type;

		/// hb_fifo_t*
		public IntPtr fifo_in;

		/// hb_fifo_t*
		public IntPtr fifo_raw;

		/// hb_fifo_t*
		public IntPtr fifo_sync;

		/// hb_fifo_t*
		public IntPtr fifo_out;

		/// hb_mux_data_t*
		public IntPtr mux_data;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct hb_subtitle_config_s
	{
		/// hb_subtitle_config_s_subdest
		public hb_subtitle_config_s_subdest dest;

		/// int
		public int force;

		/// int
		public int default_track;

		/// char[128]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string src_filename;

		/// char[40]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
		public string src_codeset;

		/// int64_t->int
		public long offset;
	}

	public enum hb_subtitle_config_s_subdest
	{
		RENDERSUB,

		PASSTHRUSUB,
	}

	public enum hb_subtitle_s_subtype
	{
		PICTURESUB,

		TEXTSUB,
	}

	public enum hb_subtitle_s_subsource
	{
		VOBSUB,

		SRTSUB,

		CC608SUB,

		CC708SUB,

		UTF8SUB,

		TX3GSUB,

		SSASUB,

		PGSSUB
	}
}
