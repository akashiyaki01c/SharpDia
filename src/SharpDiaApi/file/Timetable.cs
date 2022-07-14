using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpDiaApi.File;

/// <summary>
/// 一つの時刻表を表すクラス
/// </summary>
public sealed class Timetable {

    /// <summary> 時刻表名を表すプロパティ </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary> 下り列車の一覧を表すプロパティ </summary>
    public List<Trains> DownTrains { get; set; } = new();

    /// <summary> 上り列車の一覧を表すプロパティ </summary>
    public List<Trains> UpTrains { get; set; } = new(); 

    public Timetable() {}

    public Timetable(Timetable other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.Name is null)
            throw new ArgumentNullException(nameof(other.Name));
        if (other.DownTrains is null)
            throw new ArgumentNullException(nameof(other.DownTrains));
        if (other.UpTrains is null)
            throw new ArgumentNullException(nameof(other.UpTrains));
        this.Name = other.Name;
        this.DownTrains = other.DownTrains;
        this.UpTrains = other.UpTrains;
    }

    public Timetable(string name, List<Trains> downTrains, List<Trains> upTrains) {
        if (name is null)
            throw new ArgumentNullException(nameof(name));
        if (downTrains is null)
            throw new ArgumentNullException(nameof(downTrains));
        if (upTrains is null)
            throw new ArgumentNullException(nameof(upTrains));
        this.Name = name;
        this.DownTrains = downTrains;
        this.UpTrains = upTrains;
    }

}