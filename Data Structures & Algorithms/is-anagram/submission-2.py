class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        arr = []
        for c in s:
            arr.append(c)

        for c in t:
            if c not in arr:
                return False
            arr.remove(c)

        return len(arr) == 0