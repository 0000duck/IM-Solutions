node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat 'nuget restore InterlancedMinds-Solutions.sln'
		bat "\"${tool 'MSBuild'}\" InterlancedMinds-Solutions.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

	stage 'Archive'
		archive 'Build\**'

}
