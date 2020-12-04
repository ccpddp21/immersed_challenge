# Immersed Challenge
Repo for Immersed Phase 3 Challenge Project

## Scenario
You are a Unity engineer working on a low-fidelity “Presentation Mode” feature. You’re waiting on an API developer to finish working on their 
Rooms API to give you room joining/inviting/kicking/leaving APIs, but in the meantime, you’re working on creating the experience for a professor 
who wants to lecture in a hall with 40+ students. We’re interested in seeing how you integrate functionality from the data layer to the UI layer 
in a clean organized architecture that is scalable (even more users) and modular.

## Requirements
1. Create a basic demo level in Unity of a classroom (low-fidelity, don't spend too much time making it look nice)  with 2 different roles (or "points of view"), depending on what type of user you are (professor vs student) that can efficiently handle 40+ users (assume 1 professor max).

2. Assume that the device (ie., Oculus Quest) overheats if there are more than 7 fully-featured/functional users (avatars fully-rendered with networked movement, VoIP, etc.) in the same environment. Get creative with how the students and professor perceive the environment to solve for this optimization problem (ie., the students only see the professor + a handful of other students, and/or the professor only sees the students who are talking, and/or only a max of X number of students can talk simultaneously, etc.).

3. Assume that the room-data will be provided to you from an API endpoint but the endpoint has not yet been implemented. Your job is to create a system that asks for that data (you choose the data), stores it, then takes the user to their specific UI/UX depending on their role.

4. Since that endpoint has not yet been built, mock that data for testing within the Unity editor... but with an easy switch that could grab real data. Basically, if we were to deploy the app to a VR device, it should use an actual HTTP request, but within the editor or while some toggle is checked, it should always use mocked data.

5. Assume all data is in JSON format. Use a structure that you think makes the most sense. Feel free to have fun with the data, but include at least a name and two attributes. Your mock of the data can be done however you want (either in the editor as a ScriptableObject, in code, or from a file) but we will be looking at what exactly is mocked out.

6. After being loaded, your data should not be stored in any scene-specific object, so if this data were to be used in a later scene, it could be easily accessed.

7. Please include a brief write-up with any explanations around why you chose the route you did for any and all parts of this coding challenge. You don’t need to add any fluff, we’re just curious to hear your process.

## Short Answer Questions
1. As we look to expand more into Enterprise, what do you believe Immersed needs to prioritize from a product perspective?
2. If you were working with 2-3 other developers, what would you do to ensure that you all remain in sync and aligned on tasks?
3. Let’s say the team increases to 10-20 total developers, what changes would you anticipate in these processes to support this growth?
4. Describe the steps to take an application built specifically for Oculus and make it accessible across all platforms. Use as much detail as you can.