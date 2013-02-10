using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunesLib;

namespace JamesRSkemp.iTunes.AdvancedTrackEditor
{
	public partial class MainForm : Form
	{
		string defaultPlaylist = "Music";

		iTunesApp iTunes = null;
		IITSource librarySource = null;
		IITPlaylist playlistSource = null;
		IITTrackCollection tracks = null;

		public MainForm()
		{
			InitializeComponent();
			panelEditor.Visible = false;
			panelConnection.Visible = true;
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			iTunes = new iTunesApp();
			IITSourceCollection sources = iTunes.Sources;
			foreach (IITSource source in sources)
			{
				if (source.Kind == ITSourceKind.ITSourceKindLibrary)
				{
					librarySource = source;
					break;
				}
			}

			if (librarySource != null)
			{
				panelConnection.Visible = false;
				toolStripStatusLabelConnection.Text = "Connected to iTunes.";
				populatePlaylists();
				panelEditor.Visible = true;
			}
			else
			{
				toolStripStatusLabelConnection.Text = "iTunes connection failed.";
				MessageBox.Show("Unable to connect to iTunes or find the default library.");
				// todo
			}
		}

		private void populatePlaylists(string selectedPlaylist = "")
		{
			if (librarySource != null)
			{
				if (string.IsNullOrWhiteSpace(selectedPlaylist))
				{
					selectedPlaylist = defaultPlaylist;
				}

				foreach (IITPlaylist playlist in librarySource.Playlists)
				{
					var index = comboBoxPlaylists.Items.Add(playlist.Name);
					if (playlist.Name == selectedPlaylist)
					{
						playlistSource = playlist;
						comboBoxPlaylists.SelectedIndex = index;
					}
				}
			}
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			dataGridViewTracks.Visible = false;
			if (librarySource != null && playlistSource != null)
			{
				if (!string.IsNullOrWhiteSpace(textBoxSearchTerms.Text))
				{
					var searchTerms = textBoxSearchTerms.Text;
					tracks = playlistSource.Search(searchTerms, ITPlaylistSearchField.ITPlaylistSearchFieldAll);
				}
				else
				{
					tracks = playlistSource.Tracks;
				}
				updateTracksListing();
			}
		}

		private void updateTracksListing()
		{
			if (tracks != null)
			{
				var trackData = new List<TrackData>();
				foreach (IITTrack track in tracks)
				{
					trackData.Add(new TrackData
					{
						Id = track.trackID,
						Artist = track.Artist,
						Album = track.Album,
						Track = track.TrackNumber.ToString(),
						Disc = track.DiscNumber.ToString(),
						Rating = track.Rating,
						PlayCount = track.PlayedCount,
						LastPlayed = track.PlayedDate
					});
				}

				dataGridViewTracks.DataSource = trackData;
				dataGridViewTracks.Visible = true;
			}
		}

		private void comboBoxPlaylists_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (panelEditor.Visible)
			{
				foreach (IITPlaylist playlist in librarySource.Playlists)
				{
					if (playlist.Name == comboBoxPlaylists.Text)
					{
						playlistSource = playlist;
						break;
					}
				}
			}
		}
	}

	public class TrackData
	{
		public int Id { get; set; }
		public string Artist { get; set; }
		public string Album { get; set; }
		public string Track { get; set; }
		public string Disc { get; set; }
		public int Rating { get; set; }
		public int PlayCount { get; set; }
		public DateTime? LastPlayed { get; set; }

		public TrackData()
		{
		}
	}
}
