// https://cakebuild.net/docs/fundamentals/preprocessor-directives
#addin nuget:?package=Microsoft.ML&version=1.4.0&loaddependencies=true


using Microsoft.ML;
using Microsoft.ML.Transforms;
using Microsoft.ML.Data;

    public class Data
    {

    }

    public class IrisData
    {
        [LoadColumn(0)]
        public float SepalLength;

        [LoadColumn(1)]
        public float SepalWidth;

        [LoadColumn(2)]
        public float PetalLength;

        [LoadColumn(3)]
        public float PetalWidth;
    }

    public class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[] Distances;
    }
