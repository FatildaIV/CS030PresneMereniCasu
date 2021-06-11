using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace CS030PresneMereniCasu
{
    public partial class PresneMereniCasuForm : Form
    {
        public PresneMereniCasuForm()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            StopkyTestDateTime();
            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(Environment.NewLine);
            StopkyTestHighResolutionDateTime();
            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(Environment.NewLine);
            StopkyTestStopwatchHashSet();
            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(Environment.NewLine);
            StopkyTestStopwatch();
            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(Environment.NewLine);
            StopkyTestStopwatchDrift();
            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(Environment.NewLine);
        }

        private void StopkyTestDateTime() {

            vystupTextBox.AppendText("Testing DateTime for 1 seconds...");

            var distinctValues = new HashSet<DateTime>();
            var sw = Stopwatch.StartNew();

            while (sw.Elapsed.TotalSeconds < 1)
            {
                distinctValues.Add(DateTime.UtcNow);
            }

            sw.Stop();

            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(
                string.Format(
                    "Precision: {0:0.000000} ms ({1} samples)",
                    sw.Elapsed.TotalMilliseconds / distinctValues.Count,
                    distinctValues.Count));

        }

        private void StopkyTestHighResolutionDateTime()
        {

            vystupTextBox.AppendText("Testing High Resolution DateTime for 1 seconds...");

            var distinctValues = new HashSet<DateTime>();
            var sw = Stopwatch.StartNew();

            while (sw.Elapsed.TotalSeconds < 1)
            {
                distinctValues.Add(HighResolutionDateTime.UtcNow);
            }

            sw.Stop();

            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(
                string.Format(
                    "Precision: {0:0.000000} ms ({1} samples)",
                    sw.Elapsed.TotalMilliseconds / distinctValues.Count,
                    distinctValues.Count));

        }

        private void StopkyTestStopwatchHashSet()
        {

            vystupTextBox.AppendText("Testing Stopwatch for 1 seconds...");

            var distinctValues = new HashSet<long>();
            var sw = Stopwatch.StartNew();

            while (sw.Elapsed.TotalSeconds < 1)
            {
                distinctValues.Add(sw.ElapsedTicks);
            }

            sw.Stop();

            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(
                string.Format(
                    "Resolution: {0:0.000000} ms ({1} samples)",
                    sw.Elapsed.TotalMilliseconds / distinctValues.Count,
                    distinctValues.Count));

        }

        private void StopkyTestStopwatch()
        {

            vystupTextBox.AppendText("Testing Stopwatch for 1 seconds...");

            var sw = Stopwatch.StartNew();

            while (sw.Elapsed.TotalSeconds < 1)
            {
                
            }

            sw.Stop();

            vystupTextBox.AppendText(Environment.NewLine);
            vystupTextBox.AppendText(
                string.Format(
                    "Resolution: {0:0.000000} ms ({1} samples)",
                    sw.Elapsed.TotalMilliseconds / sw.ElapsedTicks,
                    sw.ElapsedTicks));

        }

        private void StopkyTestStopwatchDrift() {
            var start = HighResolutionDateTime.UtcNow;
            var sw = Stopwatch.StartNew();

            while (sw.Elapsed.TotalSeconds < 600)
            {
                DateTime nowBasedOnStopwatch = start + sw.Elapsed;
                TimeSpan diff = HighResolutionDateTime.UtcNow - nowBasedOnStopwatch;

                vystupTextBox.AppendText(string.Format("Stopwatch to UTC drift: {0:0.000} ms", diff.TotalMilliseconds));
                vystupTextBox.AppendText(Environment.NewLine);

                Thread.Sleep(1000);
            }
        }
    }
}
