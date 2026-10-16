class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        
        ag_dict = {}
        for s in strs:
            key = tuple(sorted(s))

            if key not in ag_dict:
                ag_dict[key] = []
            
            ag_dict[key].append(s)

        return list(ag_dict.values())
        