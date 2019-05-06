﻿using System.Drawing;
using Reactive.Bindings;



namespace BlazorTetris.ViewModels
{
    /// <summary>
    /// セル描画用のモデルを提供します。
    /// </summary>
    public class CellViewModel
    {
        #region プロパティ
        /// <summary>
        /// 色を取得します。
        /// </summary>
        public ReactiveProperty<Color> Color { get; } = new ReactiveProperty<Color>();
        #endregion
    }
}
