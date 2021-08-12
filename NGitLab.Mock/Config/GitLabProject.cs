﻿using NGitLab.Models;

namespace NGitLab.Mock.Config
{
    /// <summary>
    /// Describe a GitLab project
    /// </summary>
    public class GitLabProject : GitLabObject<GitLabConfig>
    {
        public GitLabProject()
        {
            Commits = new GitLabCommitsCollection(this);
            Issues = new GitLabIssuesCollection(this);
            MergeRequests = new GitLabMergeRequestsCollection(this);
            Permissions = new GitLabPermissionsCollection(this);
            Labels = new GitLabLabelsCollection(this);
            Milestones = new GitLabMilestonesCollection(this);
        }

        /// <summary>
        /// Name (required)
        /// </summary>
        public string Name { get; set; }

        public string Namespace { get; set; } = "unit-tests";

        public string DefaultBranch { get; set; } = "main";

        public string Description { get; set; }

        /// <summary>
        /// Path where to clone repository after server resolving
        /// </summary>
        public string ClonePath { get; set; }

        public VisibilityLevel Visibility { get; set; } = VisibilityLevel.Internal;

        public GitLabCommitsCollection Commits { get; }

        public GitLabIssuesCollection Issues { get; }

        public GitLabMergeRequestsCollection MergeRequests { get; }

        public GitLabPermissionsCollection Permissions { get; }

        public GitLabLabelsCollection Labels { get; }

        public GitLabMilestonesCollection Milestones { get; }
    }

    public class GitLabProjectsCollection : GitLabCollection<GitLabProject, GitLabConfig>
    {
        internal GitLabProjectsCollection(GitLabConfig parent)
            : base(parent)
        {
        }
    }
}
