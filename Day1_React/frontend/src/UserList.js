import React, { Component } from "react";

export default class UserList extends Component {
  render() {
    const { users } = this.props;
    return (
      <ul>
        {users.map((user) => (
          <li key={user.id}>{user.name}</li>
        ))}
      </ul>
    );
  }
}
