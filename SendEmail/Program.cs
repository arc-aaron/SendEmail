// See https://aka.ms/new-console-template for more information
using SendGrid;
using SendGrid.Helpers.Mail;

// Environment.SetEnvironmentVariable("HJkF0lPqQniUg_O7YDBH6g", "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");
// var apiKey = Environment.GetEnvironmentVariable("HJkF0lPqQniUg_O7YDBH6g");
var client = new SendGridClient("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");
var from = new EmailAddress("a.castanos@arcanys.com", "arcanytes");
var subject = "Sending with Twilio SendGrid is Fun";
var to = new EmailAddress("a.castanos@arcanys.com", "Aaron");
var plainTextContent = "and easy to do anywhere, even with C#";
var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
Console.WriteLine(response);