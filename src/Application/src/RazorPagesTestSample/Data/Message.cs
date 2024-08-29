using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a message.
/// </summary>
public class Message
{
    /// <summary>
    /// Gets or sets the ID of the message.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the text of the message.
    /// </summary>
    /// <remarks>
    /// The text of the message should not exceed 200 characters.
    /// </remarks>
    [Required]
    [DataType(DataType.Text)]
    [StringLength(250, ErrorMessage = "There's a 250 character limit on messages. Please shorten your message.")]
    public string Text { get; set; }
}
namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(250, ErrorMessage = "There's a 250 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
