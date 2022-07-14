using System;

namespace SharpDiaApi.File;

/// <summary>
/// 一つの駅時刻を表すクラス
/// </summary>
public sealed class StationTime {

    /// <summary> 到着時刻を表すプロパティ </summary>
    public Time? ArrivalTime { get; set; } = null;

    /// <summary> 発車時刻を表すプロパティ </summary>
    public Time? DepartureTime { get; set; } = null;

    /// <summary> 停車種別を表すプロパティ </summary>
    public StopType StopType { get; set; } = StopType.None;

    public StationTime() {}

    public StationTime(StationTime other) {
        this.ArrivalTime = other.ArrivalTime;
        this.DepartureTime = other.DepartureTime;
        this.StopType = other.StopType;
    }

    public StationTime(Time? arrivealTime, Time? departureTime, StopType stopType) {
        this.ArrivalTime = arrivealTime;
        this.DepartureTime = departureTime;
        this.StopType = stopType;
    }
}

/// <summary>
/// 停車種別を表す列挙体
/// </summary>
public enum StopType : byte {
    /// <summary> 運行無しを表す </summary>
    None,

    /// <summary> 停車を表す </summary>
    Stop,

    /// <summary> 通過を表す </summary>
    Pass,

    /// <summary> 運転系統を表す </summary>
    OperationalStop,

}