using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpDiaApi.File;

/// <summary>
/// 一つの運転系統を表すクラス
/// </summary>
public sealed class DriveRoute {

    /// <summary> 運転系統名を表すプロパティ </summary>
    public string Name { get; set; } = string.Empty;    


    internal List<StationIndex> stations = new();
    /// <summary> 駅参照の一覧を表すプロパティ </summary>
    public Span<StationIndex> Stations
        => CollectionsMarshal.AsSpan(stations);

    public DriveRoute() {}

    public DriveRoute(DriveRoute other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.Name is null)
            throw new ArgumentNullException(nameof(other.Name));
        if (other.stations is null)
            throw new ArgumentNullException(nameof(other.stations));
        this.Name = other.Name;
        this.stations = other.stations;
    }

    public DriveRoute(string name, List<StationIndex> stations) {
        if (name is null)
            throw new ArgumentNullException(nameof(name));
        if (stations is null)
            throw new ArgumentNullException(nameof(stations));
        this.Name = name;
        this.stations = stations;
    }

}