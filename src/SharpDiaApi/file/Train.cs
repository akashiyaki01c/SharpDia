using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SharpDiaApi.File;

/// <summary>
/// 一つの列車を表すクラス
/// </summary>
public sealed class Train {

    /// <summary> 列車種別のインデックスを表すプロパティ </summary>
    public int TrainTypeIndex { get; set; }

    /// <summary> 運転系統のインデックスを表すプロパティ </summary>
    // public int DriveRouteIndex { get; set; }

    internal List<StationTime> stationTimes = new();
    /// <summary> 駅時刻の一覧を表すプロパティ </summary>
    public Span<StationTime> StationTimes
        => CollectionsMarshal.AsSpan(this.stationTimes);
    
    public Train() {}

    public Train(Train other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.stationTimes is null)
            throw new ArgumentNullException(nameof(other.stationTimes));
        this.TrainTypeIndex = other.TrainTypeIndex;
        this.stationTimes = other.stationTimes;
    }

    public Train(int trainTypeIndex, List<StationTime> stationTimes) {
        if (stationTimes is null)
            throw new ArgumentNullException(nameof(stationTimes));
        this.TrainTypeIndex = trainTypeIndex;
        this.stationTimes = stationTimes;
    }

}