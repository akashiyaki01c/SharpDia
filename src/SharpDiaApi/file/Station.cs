using System;

namespace SharpDiaApi.File;

/// <summary>
/// 一つの駅を表すクラス
/// </summary>
public sealed class Station {

    /// <summary> 駅名を表すプロパティ </summary>
    public string Name { get; set; } = string.Empty;

    public Station() {}

    public Station(Station other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.Name is null)
            throw new ArgumentNullException(nameof(other.Name));
        this.Name = other.Name;
    }

    public Station(string name) {
        if (name is null)
            throw new ArgumentNullException(nameof(name));
        this.Name = name;
    }

}