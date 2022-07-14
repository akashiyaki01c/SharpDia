using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpDiaApi.File;

/// <summary>
/// 一つのダイヤグラムファイルを表すクラス
/// </summary>
public sealed class DiaFile {

    private List<Route> routes = new();
    /// <summary> 路線の一覧を表すプロパティ </summary>
    public Span<Route> Route
        => CollectionsMarshal.AsSpan(routes);

    private List<DriveRoute> driveRoutes = new();
    /// <summary> 運転系統の一覧を表すプロパティ </summary>
    public Span<DriveRoute> DriveRoutes
        => CollectionsMarshal.AsSpan(driveRoutes);

    private List<TrainType> trainTypes = new();
    /// <summary> 列車種別の一覧を表すプロパティ </summary>
    public Span<TrainType> TrainTypes
        => CollectionsMarshal.AsSpan(trainTypes);

    /// <summary> 時刻表の一覧を表すプロパティ </summary>
    public List<Timetable> Timetables { get; set; } = new();

    /// <summary> ファイルの設定を表すプロパティ </summary>
    public Settings Settings { get; set; } = new();


    public DiaFile() {}

    public DiaFile(DiaFile other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.routes is null)
            throw new ArgumentNullException(nameof(other.routes));
        if (other.driveRoutes is null)
            throw new ArgumentNullException(nameof(other.driveRoutes));
        if (other.trainTypes is null)
            throw new ArgumentNullException(nameof(other.trainTypes));
        if (other.Timetables is null)
            throw new ArgumentNullException(nameof(other.Timetables));
        if (other.Settings is null)
            throw new ArgumentNullException(nameof(other.Settings));
        this.routes = other.routes;
        this.driveRoutes = other.driveRoutes;
        this.trainTypes = other.trainTypes;
        this.Timetables = other.Timetables;
        this.Settings = other.Settings;
    }

    public DiaFile(
        List<Route> routes,
        List<DriveRoute> driveRoutes,
        List<TrainType> trainTypes,
        List<Timetable> timetables,
        Settings settings
    ) {
        if (routes is null)
            throw new ArgumentNullException(nameof(routes));
        if (driveRoutes is null)
            throw new ArgumentNullException(nameof(driveRoutes));
        if (trainTypes is null)
            throw new ArgumentNullException(nameof(trainTypes));
        if (timetables is null)
            throw new ArgumentNullException(nameof(timetables));
        if (settings is null)
            throw new ArgumentNullException(nameof(settings));
        this.routes = routes;
        this.driveRoutes = driveRoutes;
        this.trainTypes = trainTypes;
        this.Timetables = timetables;
        this.Settings = settings;
    }

}