using System;
namespace DepthOfNestingParenthesis
{
    public static class Helper {
        public static int GetMaxDepthOfNestingParenthesis(string str){
            var current_max = 0;
            var max = 0;
            for(int i = 0;i<str.Length;i++){
                if(str[i]=='('){
                    current_max++;
                    if (current_max>max)
                    {
                        max = current_max;
                    }
                }
                else if (str[i]==')')
                {
                    if (current_max>0)
                    {
                        current_max--;
                    }                 
                    else
                    {
                        return -1;
                    }   
                }
            }

            if (current_max == 0)
            {
                return max;
            }
            else
            {
                return -1;
            }
        }
    }
}