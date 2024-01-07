create table if not exists reactions
(
    reacted_user_id int not null,
    peer_id int not null,
    cmid int not null,
    reaction_id int not null,
    event_time timestamp not null
)