﻿using System;
using System.Security.Cryptography;
using System.Threading;



namespace BlazorTetris.Utilities
{
    /// <summary>
    /// 乱数生成機能を提供します。
    /// </summary>
    public static class RandomProvider
    {
        #region プロパティ
        /// <summary>
        /// スレッド単位で独立している乱数生成機能のラッパーを取得します。
        /// </summary>
        private static ThreadLocal<Random> RandomWrapper { get; } = new ThreadLocal<Random>(() =>
        {
            var @byte = new byte[sizeof(int)];
            using (var crypto = new RNGCryptoServiceProvider())
                crypto.GetBytes(@byte);
            var seed = BitConverter.ToInt32(@byte, 0);
            return new Random(seed);
        });


        /// <summary>
        /// スレッド単位で独立している乱数生成機能を取得します。
        /// </summary>
        public static Random ThreadRandom => RandomWrapper.Value;
        #endregion
    }
}
