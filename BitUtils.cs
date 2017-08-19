﻿/*
 * Author:  Rick
 * Create:  7/29/2017 10:26:14 AM
 * Email:   rickjiangshu@gmail.com
 * Follow:  https://github.com/RickJiangShu
 */

/// <summary>
/// 操作位工具
/// </summary>
public class BitUtils
{
    /// <summary>
    /// 掩码
    /// </summary>
    public static uint[] masks = new uint[32] { 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800, 0x1000, 0x2000, 0x4000, 0x8000,/*16位*/0x10000, 0x20000, 0x40000, 0x80000, 0x100000, 0x200000, 0x400000, 0x800000, 0x1000000, 0x2000000, 0x4000000, 0x8000000, 0x10000000, 0x20000000, 0x40000000, 0x80000000/*32位*/};

    /// <summary>
    /// 设置value的index位设置为1
    /// </summary>
    /// <param name="value"></param>
    /// <param name="index"></param>
    public static uint Set(uint value, byte index)
    {
        return value | masks[index];
    }

    /// <summary>
    /// 将value的idnex位设置为0
    /// </summary>
    /// <param name="value"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static uint Clear(uint value, byte index)
    {
        return value & ~masks[index];
    }

    /// <summary>
    /// 检查value的index位是否为1
    /// </summary>
    /// <param name="value"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static bool Get(uint value, byte index)
    {
        return (value & masks[index]) > 0;
    }
}
