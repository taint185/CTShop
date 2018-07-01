﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// Hỗ trợ xử lý chuỗi
/// </summary>
public static class XString
{
    /// <summary>
    /// Mã hóa sang chuỗi dạng base 64
    /// </summary>
    /// <param name="s">Chuỗi cần mã hóa</param>
    /// <returns>Chuỗi đã mã hóa</returns>
    public static String ToBase64(this String text)
    {
        var bytes = Encoding.UTF8.GetBytes(text);
        return Convert.ToBase64String(bytes);
    }

    /// <summary>
    /// Giải mã chuỗi mã hóa base 64
    /// </summary>
    /// <param name="s">Chuỗi đã mã hóa base 64</param>
    /// <returns>Chuỗi đã được giải mã</returns>
    public static String FromBase64(this String encodedText)
    {
        var bytes = Convert.FromBase64String(encodedText);
        return Encoding.UTF8.GetString(bytes);
    }

    /// <summary>
    /// Mã hóa MD5
    /// </summary>
    /// <param name="s">Chuỗi cần mã hóa</param>
    /// <returns>Chuỗi base 64 chứa MD5</returns>
    public static String ToMD5(this String s)
    {
        var bytes = Encoding.UTF8.GetBytes(s);
        var hash = MD5.Create().ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}