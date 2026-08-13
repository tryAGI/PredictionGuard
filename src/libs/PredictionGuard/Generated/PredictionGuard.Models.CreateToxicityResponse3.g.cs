
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToxicityResponse3
    {
        /// <summary>
        /// Unique ID for the toxicity check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (toxicity.check).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the toxicity check was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The set of vectorized data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::PredictionGuard.CreateToxicityResponseCheck>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToxicityResponse3" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the toxicity check.
        /// </param>
        /// <param name="object">
        /// Type of object (toxicity.check).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the toxicity check was created.
        /// </param>
        /// <param name="checks">
        /// The set of vectorized data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToxicityResponse3(
            string? id,
            string? @object,
            int? created,
            global::System.Collections.Generic.IList<global::PredictionGuard.CreateToxicityResponseCheck>? checks)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToxicityResponse3" /> class.
        /// </summary>
        public CreateToxicityResponse3()
        {
        }

    }
}