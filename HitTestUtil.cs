/*
 * Author:  Rick
 * Create:  2017/8/19 9:29:06
 * Email:   rickjiangshu@gmail.com
 * Follow:  https://github.com/RickJiangShu
 */
using UnityEngine;

/// <summary>
/// 用于碰撞检测
/// </summary>
public class HitTestUtil
{
    /// <summary>
    /// 范围检测
    /// </summary>
    /// <returns></returns>
    public static bool Range(Vector3 self, Vector3 target, float radius)
    {
        return Vector3.Distance(self, target) < radius;
    }
    /// <summary>
    /// 范围检测（平面）
    /// </summary>
    /// <returns></returns>
    public static bool RangePlane(Vector3 self, Vector3 target, float radius)
    {
        float dx = self.x - target.x;
        float dy = self.y - target.y;
        return Mathf.Sqrt(dx * dx + dy * dy) < radius;
    }
}
