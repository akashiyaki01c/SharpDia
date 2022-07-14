using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpDiaApi.File;

/// <summary>
/// 列車の集合を表すクラス
/// </summary>
public class Trains {

    internal List<Train> value = new();
    /// <summary> 列車群を表すプロパティ </summary>
    public Span<Train> Value
        => CollectionsMarshal.AsSpan(value);

    public Trains() {}

    public Trains(Trains other) {
        if (other is null)
            throw new ArgumentNullException(nameof(other));
        if (other.value is null)
            throw new ArgumentNullException(nameof(other.value));
        this.value = other.value;
    }

    public Trains(List<Train> value) {
        if (value is null)
            throw new ArgumentNullException(nameof(value));
        this.value = value;
    }

}