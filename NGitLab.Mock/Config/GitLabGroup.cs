﻿using NGitLab.Models;

namespace NGitLab.Mock.Config
{
    /// <summary>
    /// Describe a GitLab group
    /// </summary>
    public class GitLabGroup : GitLabObject<GitLabConfig>
    {
        public GitLabGroup()
        {
            Labels = new GitLabLabelsCollection(this);
            Permissions = new GitLabPermissionsCollection(this);
        }

        /// <summary>
        /// Name (required)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Parent namespace
        /// </summary>
        public string Namespace { get; set; }

        public string Description { get; set; }

        public VisibilityLevel Visibility { get; set; } = VisibilityLevel.Internal;

        public GitLabLabelsCollection Labels { get; }

        public GitLabPermissionsCollection Permissions { get; }
    }

    public class GitLabGroupsCollection : GitLabCollection<GitLabGroup, GitLabConfig>
    {
        internal GitLabGroupsCollection(GitLabConfig parent)
            : base(parent)
        {
        }
    }
}
