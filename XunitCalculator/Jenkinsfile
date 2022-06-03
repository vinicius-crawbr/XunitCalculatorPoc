#!groovy
pipeline{
    agent{label "linux"}
    stages("build"){
        steps{
            sh """"
                docker build -t xunit .
            """

        }

    }
}