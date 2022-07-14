using System;

namespace SharpDiaApi.File;

/// <summary>
/// 秒単位の時刻を表す構造体
/// </summary>
public readonly struct Time {
    
    /// <summary> 時刻を表すフィールド </summary>
    private readonly int value;

    /// <summary> 時を表すプロパティ </summary>
    public int Hour
        => (this.value / (60*60) ) % 24;
    
    /// <summary> 分を表すプロパティ </summary>
    public int Minute
        => (this.value / 60) % 60;

    /// <summary> 秒を表すプロパティ </summary>
    public int Second
        => this.value % 60;


    public Time(int value) {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));
        this.value = value % (60*60*24);
    }

    public Time(int hour, int minute, int second) {
        if (hour < 0)
            throw new ArgumentOutOfRangeException(nameof(hour));
        if (minute < 0)
            throw new ArgumentOutOfRangeException(nameof(minute));
        if (second < 0)
            throw new ArgumentOutOfRangeException(nameof(second));
        this.value = (hour*60*60 + minute*60 + second) % (60*60*24);
    }

}