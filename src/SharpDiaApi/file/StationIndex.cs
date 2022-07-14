using System;

namespace SharpDiaApi.File;

/// <summary>
/// 駅への参照を表す構造体
/// </summary>
public readonly struct StationIndex {

    /// <summary> 路線インデックスを表すフィールド </summary>
    public readonly int RouteIndex;

    /// <summary> 駅インデックスを表すフィールド </summary>
    public readonly int StaIndex;

    public StationIndex(int routeIndex, int staIndex) {
        this.RouteIndex = routeIndex;
        this.StaIndex = staIndex;
    }
}