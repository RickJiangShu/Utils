/*
 * Author:  Rick
 * Create:  2017/8/19 9:06:03
 * Email:   rickjiangshu@gmail.com
 * Follow:  https://github.com/RickJiangShu
 */
using UnityEngine;

/// <summary>
/// 用于坐标转换
/// </summary>
public class CoordinateUtil
{
    /// <summary>
    /// 世界坐标转换到Canvas坐标
    /// </summary>
    /// <returns></returns>
    public static Vector3 World2Canvas(Vector3 position, Camera camera, RectTransform canvas)
    {
        Vector2 viewport = camera.WorldToViewportPoint(position);
        viewport = (viewport - canvas.pivot) * 2;
        float w = canvas.rect.width * 0.5f;
        float h = canvas.rect.height * 0.5f;
        return new Vector2(viewport.x * w, viewport.y * h);
    }

    /// <summary>
    /// Canvas坐标转换到世界坐标
    /// </summary>
    /// <returns></returns>
    public static Vector3 Canvas2World(Vector3 position, Camera camera, RectTransform canvas)
    {
        float w = canvas.rect.width * 0.5f;
        float h = canvas.rect.height * 0.5f;
        Vector3 viewport = new Vector3((position.x / w + 1f) / 2, (position.y / h + 1f) / 2, position.z);
        return camera.ViewportToWorldPoint(viewport);
    }
}
