using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpDiaApi.File;

/// <summary>
/// 一つの路線を表すクラス
/// </summary>
public sealed class Route {

    /// <summary> 路線名を表すプロパティ </summary>
    public string Name { get; set; } = string.Empty;

    internal List<Station> stations = new();
    /// <summary> 駅の一覧を表すプロパティ </summary>
    public Span<Station> Stations
        => CollectionsMarshal.AsSpan(stations);

    public Route() {}

    public Route(Route other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.Name is null)
            throw new ArgumentNullException(nameof(other.Name));
        if (other.stations is null)
            throw new ArgumentNullException(nameof(other.stations));
        this.Name = other.Name;
        this.stations = other.stations;
    }

    public Route(string name, List<Station> stations) {
        if (name is null)
            throw new ArgumentNullException(nameof(name));
        if (stations is null)
            throw new ArgumentNullException(nameof(stations));
        this.Name = name;
        this.stations = stations;
    }

}