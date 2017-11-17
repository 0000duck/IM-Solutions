pipeline
{
	agent any

	stages {
		stage ('Checkout')
		{
			steps
			{
				checkout scm
			}
		}
		stage ('Build')
		{
			steps
			{
				sh 'nuget restore InterlancedMinds-Solutions.sln'
				sh "\"${tool 'MSBuild'}\" InterlancedMinds-Solutions.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
			}
		}
		stage ('Archive')
		{
			steps
			{
			archive 'Build/**'
			}
		}
	}
}