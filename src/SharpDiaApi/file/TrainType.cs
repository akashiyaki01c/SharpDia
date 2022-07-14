using System;

namespace SharpDiaApi.File;

/// <summary>
/// 一つの列車種別を表すクラスS
/// </summary>
public sealed class TrainType {

    /// <summary> 列車種別名を表すプロパティ </summary>
    public string Name { get; set; } = string.Empty;

    public TrainType() {}

    public TrainType(TrainType other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.Name is null)
            throw new ArgumentNullException(nameof(other.Name));
        this.Name = other.Name;
    }

    public TrainType(string name) {
        if (name is null)
            throw new ArgumentNullException(nameof(name));
        this.Name = name;
    }
}