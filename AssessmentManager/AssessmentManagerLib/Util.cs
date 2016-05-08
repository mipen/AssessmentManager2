using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentManager
{
    public static class Util
    {

        public static readonly string ASSESSMENT_EXT = ".exm";

        public static void PopulateTreeView(TreeView treeView, Assessment assessment)
        {
            treeView.Nodes.Clear();

            List<QuestionNode> nodeList = new List<QuestionNode>();
            foreach (var q in assessment.Questions)
            {
                nodeList.Add(BuildQuestionNodeRecursive(q));
            }

            treeView.Nodes.AddRange(nodeList.ToArray());
        }

        /// <summary>
        /// Builds a Node for the given Question for use in a TreeView. If the Question has subquestions, the
        /// method will recursively call itself to build a Node for those questions as well, adding them to the top level
        /// node's NodesCollection.
        /// </summary>
        /// <param name="question">The question for which to build the QuestionNode.</param>
        /// <returns>A QuestionNode for use in a TreeView which contains a reference to the question, along with sub 
        /// nodes for any sub questions the given question may have had.</returns>
        public static QuestionNode BuildQuestionNodeRecursive(Question question)
        {
            //Builds a tree node for the given question
            QuestionNode node = new QuestionNode(question);
            //If the quesiton has subquestions, then recursively go through each one and build a node for that as well
            if (question.HasSubQuestions)
            {
                foreach (var q in question.SubQuestions)
                {
                    QuestionNode n = BuildQuestionNodeRecursive(q);
                    node.Nodes.Add(n);
                }
            }
            return node;
        }

        public static void RebuildAssessmentQuestionList(Assessment assessment, TreeView treeView)
        {
            //Shorter call to rebuild the entire question list of the given assessment from the given treeview
            BuildQuestionListFromNodeCollection(assessment.Questions, treeView.Nodes);
        }

        public static void BuildQuestionListFromNodeCollection(List<Question> questionList, TreeNodeCollection nodeCollection)
        {
            //First clear the list
            questionList.Clear();
            //Make sure that there is something in the node collection
            if (nodeCollection.Count > 0)
            {
                for (int i = 0; i < nodeCollection.Count; i++)
                {
                    QuestionNode node = (QuestionNode)nodeCollection[i];

                    node.Question.Name = $"Question {GetQuestionLevelIndex(node)}";
                    node.Text = node.Question.Name;
                    questionList.Add(node.Question);
                    if (node.Nodes.Count > 0)
                    {
                        BuildQuestionListFromNodeCollection(node.Question.SubQuestions, node.Nodes);
                    }
                }
            }
        }

        public static string GetQuestionLevelIndex(QuestionNode node)
        {
            List<string> strList = new List<string>();

            do
            {
                strList.Add((node.Index + 1).ToString());
                node = (QuestionNode)node.Parent;
            } while (node != null);

            string str = "";
            for (int i = strList.Count - 1; i >= 0; i--)
            {
                str += strList[i];
                if (i > 0) str += ".";
            }

            return str;
        }
    }
}
