
import React, { useState, useEffect } from "react";
import UserList from "./UserList";
import UserForm from "./UserForm";

function App() {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5000/users")
      .then(res => res.json())
      .then(data => setUsers(data));
  }, []);

  const addUser = async (name) => {
    const res = await fetch("http://localhost:5000/users", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ name })
    });
    const newUser = await res.json();
    setUsers([...users, newUser]);
  };

  return (
    <div style={{ margin: "20px" }}>
      <h1>User Management System</h1>
      <UserForm onAddUser={addUser} />
      <UserList users={users} />
    </div>
  );
}
export default App;